import { Injectable } from '@angular/core';
import { BaseModel } from 'src/app/models/base/baseModels';
import { MovieModel } from 'src/app/models/moviesModel';
import { BaseHttpService } from './base-services/base-http.service';
import { map, Observable, tap } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private httpClient: BaseHttpService) {
  }
  getMovies(): Observable<BaseModel<MovieModel>> {
    return this.httpClient.get<BaseModel<MovieModel>>({
      controller: "Movies",
      action: "GetAllMovies"
    }).pipe(
      tap(data => console.log("fetch data,", data)
    ));
  }
}
