import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomersComponent } from './customers.component';
import { RouterModule } from '@angular/router';
import { UserInfoDirective } from 'src/app/directives/user-info.directive';



@NgModule({
  declarations: [
    CustomersComponent,
    UserInfoDirective
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([{ path: "", component: CustomersComponent }])
  ]
})
export class CustomersModule { }
