import { Component, OnInit } from '@angular/core';
import { Form } from '@angular/forms';
import { PackageItemRelation } from 'src/app/models/packageItemModel';
import { Package } from 'src/app/models/packageModel';
import { PackageService } from 'src/app/services/http-services/package.service';

@Component({
  selector: 'app-create-edit',
  templateUrl: './create-edit.component.html',
  styleUrls: ['./create-edit.component.css']
})
export class CreateEditComponent implements OnInit {
  package: Package = new Package();
  constructor(public packageService:PackageService) {
    this.package.packageItemRelations = [];
  }
  ngOnInit(): void {
  }

  async create($event: any, title: HTMLInputElement, description: HTMLInputElement, totalSalary: HTMLInputElement, dietTotal: HTMLInputElement, pilatesTotal: HTMLInputElement, packageForm: HTMLFormElement) {
    this.package=new Package();
    this.package.packageItemRelations=[];
    $event.preventDefault();
    console.log('girdi');
    debugger;
    this.package.description = description.value;
    this.package.totalSalary = Number.parseInt(totalSalary.value);
    this.package.title = title.value;
    console.log(packageForm);
    if (Number.parseInt(dietTotal.value) > 0) {
      var dietPackage: PackageItemRelation = new PackageItemRelation();
      dietPackage.packageType = 1;
      dietPackage.title = "diyet";
      dietPackage.total = Number.parseInt(dietTotal.value);
      this.package.packageItemRelations.push(dietPackage);
    }

    if (Number.parseInt(pilatesTotal.value)) {
      var pilatesPackage: PackageItemRelation = new PackageItemRelation();
      pilatesPackage.packageType = 2;
      pilatesPackage.title = "pilates";
      pilatesPackage.total = Number.parseInt(dietTotal.value);
      this.package.packageItemRelations.push(pilatesPackage);
    }
    console.log(this.package);

    await this.packageService.push(this.package);
  }

}
