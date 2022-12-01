import { Component, OnInit } from '@angular/core';
import { Package } from 'src/app/models/packageModel';
import { PackageService } from 'src/app/services/http-services/package.service';

@Component({
  selector: 'app-packages',
  templateUrl: './packages.component.html',
  styleUrls: ['./packages.component.css']
})
export class PackagesComponent implements OnInit {
  packageList:Array<Package>=[];
  constructor(private packageService:PackageService) {
    this.packageService.get().then(data=>{
      this.packageList=data.data;
      console.log(data.data)
    });
  }

ngOnInit():void {
    // debugger;
    // var result=await this.packageService.get();
    // this.packageList= result.data;
    // this.packageList.forEach(i=>{
    //   i.packageItemRelations.length
    // })
    // console.log(this.packageList);
  }
  async deletePackage(id:Number)
  {
      await this.packageService.delete(id.toString());
  }
}
