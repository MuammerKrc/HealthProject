import { Component, OnInit } from '@angular/core';
import { BaseModel } from 'src/app/models/base/baseModels';
import { MovieModel } from 'src/app/models/moviesModel';
import { CustomToastrOptions, CustomToastService } from 'src/app/services/common/custom-toast.service';
import { BaseHttpService } from 'src/app/services/http-services/base-services/base-http.service';
import { MoviesComponent } from '../movies/movies.component';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor(private httpService: BaseHttpService) { }

  ngOnInit(): void {

    this.httpService.get<BaseModel<MovieModel>>({
      controller: "movies",
      action: "getAllMovies"
    }).subscribe(i => {
      debugger;
      var result: BaseModel<MovieModel> = i;
      result.data.forEach(x => {
        console.log(x.title);
      });
    })
  }
}
