import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable()
export class InfoService {

  constructor(private http: HttpClient) { }
  
  GetDierection(){
    return this.http.get('/api/applications');
  }

}
