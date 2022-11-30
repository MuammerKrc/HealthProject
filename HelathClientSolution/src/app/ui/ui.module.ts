import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeModule } from './home/home.module';
import { RegisterModule } from './register/register.module';
import { LoginModule } from './login/login.module';
import { UserInfoModule } from './user-info/user-info.module';
import { WriteDietModule } from './write-diet/write-diet.module';
import { PackagesModule } from './packages/packages.module';



@NgModule({
  declarations: [

  ],
  imports: [
    CommonModule,
    HomeModule,
    RegisterModule,
    LoginModule,
    UserInfoModule,
    WriteDietModule,
    PackagesModule
  ]
})
export class UiModule { }
