import { Component, OnInit } from '@angular/core';
import { BaseHttpService } from 'src/app/services/http-services/base-services/base-http.service';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {
  constructor(private httpClient: BaseHttpService) { }
  ngOnInit(): void {
  }
}
