import { Component, Input, OnInit } from '@angular/core';
import { cards } from '../Models/cards';

@Component({
  selector: 'app-carteira',
  templateUrl: './carteira.component.html',
  styleUrls: ['./carteira.component.css']
})
export class CarteiraComponent implements OnInit {
  hideCards:boolean = false;
  cards:cards = new cards();
  constructor() { }

  ngOnInit() {
  }

  gerarQrCode(business:number){
    debugger;
    this.hideCards = true;
    switch ( business ) {
      case 1:
          // statement 1
          this.cards = {
            empresa:'Tim',
            co2NaoEmitido:'30.032 metros cúbicos',
            prazoExpiracao:'01/01/2022',
            usuariosAlcancados:'22.000',
            pontoDeRetirada:'Lojas Físicas, Aplicativo, SMS'
          }
          break;
      case 2:
          // statement 2
          this.cards = {
            empresa:'MC Donalds',
            co2NaoEmitido:'25.232 metros cúbicos',
            prazoExpiracao:'01/02/2022',
            usuariosAlcancados:'10.000',
            pontoDeRetirada:'Drive thrus'
          }
          break;
      case 3:
          // statement N
          this.cards = {
            empresa:'Prefeitura do Rio de Janeiro',
            co2NaoEmitido:'6.000',
            prazoExpiracao:'05/02/2022',
            usuariosAlcancados:'5.678',
            pontoDeRetirada:'Postos de Saúde'
          }
          break;
      case 4:
            // statement N
            this.cards = {
              empresa:'Sus',
              co2NaoEmitido:'19.432',
              prazoExpiracao:'01/122022',
              usuariosAlcancados:'4.543',
              pontoDeRetirada:'Upas'
            }
            break;
      case 5:
          // statement N
          this.cards = {
            empresa:'GreenPeace',
            co2NaoEmitido:'28.454',
            prazoExpiracao:'01/03/2022',
            usuariosAlcancados:'11.543',
            pontoDeRetirada:'Polo Greenpeace Rj'
          }
          break;
      case 6:
          // statement N
          this.cards = {
            empresa:'Prefeitura de São Paulo',
            co2NaoEmitido:'11.574',
            prazoExpiracao:'01/12/2021',
            usuariosAlcancados:'5.542',
            pontoDeRetirada:'MASP, Centro Cultural de São Paulo'
          }
          break;
      default: 
          // 
          break;
   }
  }

  getCardsBack(){
    this.hideCards = false;
  }

}
