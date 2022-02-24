import { Component, OnInit } from '@angular/core';
import { login } from '../../Models/login';
import { LoginService } from 'src/app/services/login.service'; 
import {Router} from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  email:string;
  senha:string;
  login:login = new login();
  constructor(private _loginService:LoginService,private router: Router) { }

  ngOnInit() {
  }

  logar(){
    this.login.email = this.email;
    this.login.senha = this.senha
    this._loginService.login(this.login).subscribe(response => {
      debugger;
      console.log(response)
      localStorage.setItem("name",JSON.stringify(response.nome));
      localStorage.setItem("email",JSON.stringify(response.email));
      localStorage.setItem("userType",JSON.stringify(response.tipoCadastro));
      this.router.navigateByUrl('/home-usuario');
    },error => {
      alert('Login ou senha incorretos')
    })
  }

}
