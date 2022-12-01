import { Injectable } from '@angular/core';
import { firstValueFrom, Observable } from 'rxjs';
import { BaseModel } from 'src/app/models/base/baseModels';
import { NoResponse } from 'src/app/models/base/noResponse';
import { Package } from 'src/app/models/packageModel';
import { BaseHttpService } from './base-services/base-http.service';

@Injectable({
  providedIn: 'root'
})
export class PackageService {
  packageBaseUrl: string = "Package";


  constructor(private httpClient: BaseHttpService) { }

  async get(): Promise<BaseModel<Array<Package>>> {
    var observable: Observable<BaseModel<Array<Package>>> = this.httpClient.get<BaseModel<Array<Package>>>({
      controller: this.packageBaseUrl
    });
    return await firstValueFrom(observable);
  }
  async push(packages:Package):Promise<NoResponse>{
    var observable:Observable<NoResponse>=this.httpClient.post({
      controller:this.packageBaseUrl,
    },packages);
    return await firstValueFrom(observable);
  }
  async delete(id:string):Promise<NoResponse>{
    var observable:Observable<NoResponse>=this.httpClient.delete({controller:this.packageBaseUrl},id);
    return await firstValueFrom(observable);
  }
}
