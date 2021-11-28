import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { parceiro } from '../Models/parceiro';
import { usuario } from '../Models/usuario';


@Injectable({
  providedIn: 'root'
})
export class CadastroEntidadeService {

  usuarioUrl = 'https://localhost:5001/Usuario';
  
  constructor(private http:HttpClient) { }

  cadastroUsuario(usuario:usuario): Observable<any> {
    const headers = { 'content-type': 'application/json'}  
    const body = usuario;
    return this.http.post(this.usuarioUrl, body,{'headers':headers})
  }
  cadastroParceiro(parceiro:parceiro): Observable<any> {
    debugger;
    const headers = { 'content-type': 'application/json'}  
    const body = parceiro;
    return this.http.post(this.usuarioUrl, body,{'headers':headers})
  }
}
