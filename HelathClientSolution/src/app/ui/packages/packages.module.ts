import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PackagesComponent } from './packages.component';
import { RouterModule } from '@angular/router';
import { CreateEditModalComponent } from './create-edit-modal/create-edit-modal.component';
import { CreateEditComponent } from './create-edit/create-edit.component';



@NgModule({
  declarations: [
    PackagesComponent,
    CreateEditModalComponent,
    CreateEditComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([{ path: "", component: PackagesComponent }])
  ]
})
export class PackagesModule { }
