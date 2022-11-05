import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './ui/home/home.component';

const routes: Routes = [

  { path: "", component: HomeComponent },
  { path: "register", loadChildren: () => import('./ui/register/register.module').then(module => module.RegisterModule) },
  { path: "login", loadChildren: () => import('./ui/login/login.module').then(module => module.LoginModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
