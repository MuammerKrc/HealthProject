import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { TitleStrategy } from '@angular/router';
import { LoginModel } from 'src/app/models/authModels/loginModel';
import { AuthService } from 'src/app/services/http-services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  constructor(private authService: AuthService) { }
  ngOnInit(): void {
  }
  loginForm: FormGroup = new FormGroup({
    email: new FormControl(null, [Validators.email, Validators.required]),
    password: new FormControl(null, [Validators.min(5), Validators.required])
  });
  loginModel: LoginModel;
  loginClick() {
    this.loginModel = this.loginForm.value as LoginModel;
    this.authService.login(this.loginModel).subscribe(i => {});
  }
}
