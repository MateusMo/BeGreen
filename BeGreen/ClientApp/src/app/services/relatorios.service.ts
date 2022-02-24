import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class RelatoriosService {

  constructor(private http:HttpClient) { }

  getUserReport(){
    let login = `https://localhost:5001/UserReport`
    return this.http.get<any>(login)
  }
}
