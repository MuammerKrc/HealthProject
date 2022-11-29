import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { firstValueFrom, map, mapTo, Observable, take, tap } from 'rxjs';
import { CustomerModel } from 'src/app/models/authModels/customerModel';
import { BaseModel } from 'src/app/models/base/baseModels';
import { BaseHttpService } from './base-services/base-http.service';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  constructor(private _httpClient: BaseHttpService) {

  }
  async get(): Promise<BaseModel<CustomerModel[]>> {
    const basketObser: Observable<BaseModel<CustomerModel[]>> = this._httpClient.get<BaseModel<CustomerModel[]>>({ controller: "customer" });
    return await firstValueFrom(basketObser);
  }
  


}
