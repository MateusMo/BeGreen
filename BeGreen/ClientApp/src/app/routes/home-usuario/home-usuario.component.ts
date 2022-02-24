import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home-usuario',
  templateUrl: './home-usuario.component.html',
  styleUrls: ['./home-usuario.component.css']
})
export class HomeUsuarioComponent implements OnInit {

  nome:string;
  email:string;
  userType:string;

  title = 'My first AGM project';
  lat = -22.89544424627357;
  lng = -43.179315610172424;
  constructor() { }

  ngOnInit() {
    debugger;
    this.nome = localStorage.getItem("name");
    this.nome = this.nome.replace(/['"]+/g, '')
    this.email = localStorage.getItem("email");
    this.email = this.email.replace(/['"]+/g, '');
    this.userType = localStorage.getItem("userType");
  }

}


