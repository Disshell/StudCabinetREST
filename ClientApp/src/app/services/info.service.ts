import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable()
export class InfoService {

  constructor(private http: HttpClient) { }
  
  GetDierection(){
    return this.http.get('/api/info/directions');
  }

  GetСertificatetypes(){
    return this.http.get('/api/info/certificatetypes')
  }

  GetInstitutiontypes(){
    return this.http.get('/api/info/institutiontypes')
  }

  GetFaculties(){
    return this.http.get('/api/info/faculties')
  }

  GetSpecializations(){
    return this.http.get('/api/info/specializations')
  }

  GetObjects(){
    return this.http.get('/api/info/objects')
  }

}
