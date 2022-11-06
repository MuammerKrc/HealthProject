import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './layout/layout.component';
import { HomeComponent } from './ui/home/home.component';
import { LoginComponent } from './ui/login/login.component';

const routes: Routes = [
  {
    path: "", component: LayoutComponent, children: [
      { path: "", component: HomeComponent },
      { path: "customers", loadChildren: () => import("./ui/customers/customers.module").then(i => i.CustomersModule) },
    ]
  },
  { path: "register", loadChildren: () => import('./ui/register/register.module').then(module => module.RegisterModule) },
  { path: "login", component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
