import { Component, OnInit } from '@angular/core';

declare let $:any;

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {
  expanded: boolean = false;

  constructor() { }

  ngOnInit(): void {
  }
  toogleSidebar() {
    let navigation = document.querySelector('aside');
    let mainContent = document.querySelector('.main-contents');
    let toggle = document.querySelector('.close-toggle');
    this.expanded = !this.expanded;
    $('html , .main-contents').toggleClass('active');
  }
}

