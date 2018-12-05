import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable()
export class InfoService {

  constructor(private http: HttpClient) { }
  
  GetDierection(){
    return this.http.get('/api/applications');
  }

  GetEducationType(){
    return this.http.get('/api/info')
  }

  GetObjects(){
    return this.http.get('/api/info/objects')
  }

}
