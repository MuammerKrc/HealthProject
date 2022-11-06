import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar/navbar.component';
import { RouterModule } from '@angular/router';
import { SidebarComponent } from './sidebar/sidebar.component';
import { RightSideComponent } from './right-side/right-side.component';
import { LayoutComponent } from './layout.component';



@NgModule({
  declarations: [
    NavbarComponent,
    SidebarComponent,
    RightSideComponent,
    LayoutComponent
  ],
  imports: [
    CommonModule,
    RouterModule

  ]
  , exports: [
    NavbarComponent,
    SidebarComponent,
    RightSideComponent
  ]
})
export class LayoutModule { }
