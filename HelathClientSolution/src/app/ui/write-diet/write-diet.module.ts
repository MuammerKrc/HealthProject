import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WriteDietComponent } from './write-diet.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    WriteDietComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([{ path: "", component: WriteDietComponent }])
  ]
})
export class WriteDietModule { }
