import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { RouterModule, RouterOutlet } from '@angular/router';
import { LayoutModule } from 'src/app/layout/layout.module';



@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([{ path: "", component: HomeComponent }])
  ]
})
export class HomeModule { }
