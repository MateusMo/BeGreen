import { Component, OnInit } from '@angular/core';
import { CadastroEntidadeService } from '../services/cadastro-entidade.service';
import { parceiro } from '../Models/parceiro';
import { usuario } from '../Models/usuario';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css']
})
export class CadastroComponent implements OnInit {

  //objetos
  usuario: usuario = new usuario();
  parceiro: parceiro = new parceiro();
  //propriedades auxiliares
  email: string;
  senha: string;
  genero: any;

  //lógica de ngIf
  isBusiness: any = null;
  hideNext: boolean = false;

  constructor(private _cadastroEntidade: CadastroEntidadeService) { }

  ngOnInit() {
  }
  //Função chamada na primeira parte do cadastro
  proximo() {
    this.isBusiness = (<HTMLInputElement>document.getElementById("inputState")).value;
    if(this.email == null || this.senha == null || this.isBusiness == null){
      alert('preencha todos os campos')
    } else {
      this.hideNext = true;
      //verifica se é usuário ou parceiro
      this.isBusiness == 'Usuário' ? this.isBusiness = 0 : this.isBusiness = 1;
      this.hideNext = true;
    }
  }
  //Função chamada para finalizar o cadastro
  //Definição se é usuário ou parceiro
  cadastrarUsuario() {
    //verifica se é usuário
    if (this.isBusiness == 0) {
      this.usuario.email = this.email;
      this.usuario.senha = this.senha;
      this.usuario.tipoCadastro = 1;
      //verifica gênero do usuário
      this.genero = (<HTMLInputElement>document.getElementById("inputState1")).value;
      if (this.genero == 'Masculino') {
        this.usuario.genero = 2;
      } else if (this.genero == 'Feminino') {
        this.usuario.genero = 1;
      } else if (this.genero == 'Outro') {
        this.usuario.genero = 3
      } 
      console.log(this.usuario)
      //chamada api
      this._cadastroEntidade.cadastroUsuario(this.usuario).subscribe(
        
      )
    } 
    //verifica se é empresa
    else {
      this.parceiro.email = this.email;
      this.parceiro.senha = this.senha;
      this.parceiro.tipoDeCadastro = 2;
      this.parceiro.ramo = (<HTMLInputElement>document.getElementById("inputState2")).value;
      //chamada api
      console.log(this.parceiro)
      this._cadastroEntidade.cadastroParceiro(this.parceiro).subscribe(response => {

      },error => {

      })
    }
  }

}
