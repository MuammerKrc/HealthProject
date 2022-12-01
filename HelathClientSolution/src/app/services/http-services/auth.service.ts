import { HttpClient } from '@angular/common/http';
import { Inject, inject, Injectable } from '@angular/core';
import { BehaviorSubject, Observable, tap } from 'rxjs';
import { AuthResponse } from 'src/app/models/authModels/authResponse';
import { LoginModel } from 'src/app/models/authModels/loginModel';
import { SignModel } from 'src/app/models/authModels/signModel';

import { BaseModel } from 'src/app/models/base/baseModels';
import { NoResponse } from 'src/app/models/base/noResponse';
import { UserModel } from 'src/app/models/userModel';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  loginUrl: string = "";
  registerUrl: string = "";
  loginRefreshToken: string = "";
  constructor(private http: HttpClient, @Inject("baseUrl") private baseUrl: string) {
    this.loginUrl = this.baseUrl + "Auth/Login";
    this.loginRefreshToken = this.baseUrl + "Auth/LoginWithRefreshToken";
    this.registerUrl = this.baseUrl + "users";
  }

  userObser = new BehaviorSubject<UserModel>(null);

  signUp(model: SignModel): Observable<BaseModel<NoResponse> | null> {
    return this.http.post<BaseModel<NoResponse>>(this.registerUrl, model).pipe(tap(response => {
      debugger;
      if (response.isSuccess) {
        //bilgi gösterilecek
      } else {
        //hata gösterilecek
      }
    }));
  }

  login(model: LoginModel): Observable<BaseModel<AuthResponse> | null> {
    return this.http.post<BaseModel<AuthResponse>>(this.loginUrl, model).pipe(tap(response => {
      debugger;
      if (response.isSuccess) {
        this.createUserModel(response.data);
      } else {
        //hata gösterilecek
      }
    }));
  }

  autoLogin() {
    var user: UserModel = JSON.parse(localStorage.getItem('user')) as UserModel;
    if (!user) {
      return;
    }
    if (user.token) {
      this.userObser.next(user);
    }
  }

  logout() {
    this.userObser.next(null);
    localStorage.removeItem("user");
  }


  createUserModel(response?: AuthResponse) {
    var expirationDate = new Date(response.expirationAccessToken);
    var newuser = new UserModel("", response.accessToken, expirationDate, response.refresToken);
    this.userObser.next(newuser);
    localStorage.setItem("user", JSON.stringify(newuser));
  }


}
