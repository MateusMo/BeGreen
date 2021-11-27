import { Component, OnInit } from '@angular/core';
import { parceiro } from '../Models/parceiro';
import { usuario } from '../Models/usuario';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css']
})
export class CadastroComponent implements OnInit {

  //objetos e propriedades auxiliares
  usuario:usuario = new usuario();
  parceiro:parceiro = new parceiro();
  email:string;
  senha:string;
  genero:any;

  //lógica de ngIf
  isBusiness:any = null;
  hideNext:boolean = false;

  constructor() { }

  ngOnInit() {
  }

  finalizarCadastro(){
    this.hideNext = true;
    //verifica se é usuário ou parceiro
    this.isBusiness = (<HTMLInputElement>document.getElementById("inputState")).value;
    this.isBusiness == 'Usuário' ? this.isBusiness = 0 : this.isBusiness = 1;
    this.hideNext = true;
  }

  cadastrarUsuario(){
    debugger;
    if(this.isBusiness == 0){
      this.usuario.email = this.email;
      this.usuario.senha = this.senha;
      this.usuario.tipoCadastro = 0;
      //verifica gênero do usuário
     this.genero = (<HTMLInputElement>document.getElementById("inputState1")).value;
     if(this.genero == 'Masculino'){
       this.usuario.genero = 0;
     } else if(this.genero == 'Feminino') {
       this.usuario.genero = 1;
     }else if(this.genero == 'Outro'){
       this.usuario.genero = 2
     }
     console.log(this.usuario)
    } else {
      this.parceiro.ramo = (<HTMLInputElement>document.getElementById("inputState2")).value;
    }
  }

}
