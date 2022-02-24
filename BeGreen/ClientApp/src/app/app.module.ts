import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './routes/nav-menu/nav-menu.component';
import { HomeComponent } from './routes/home/home.component';
import { CounterComponent } from './routes/counter/counter.component';
import { FetchDataComponent } from './routes/fetch-data/fetch-data.component';
import { LoginComponent } from './routes/login/login.component';
import { HomeUsuarioComponent } from './routes/home-usuario/home-usuario.component';
import { CadastroComponent } from './routes/cadastro/cadastro.component';
import { RedefinirSenhaComponent } from './routes/redefinir-senha/redefinir-senha.component';
import { CarteiraComponent } from './routes/carteira/carteira.component';
import { AgmCoreModule } from '@agm/core';
import { CarbonoComponent } from './routes/carbono/carbono.component';
import { BlogComponent } from './routes/blog/blog.component';
import { CadastroPromocaoComponent } from './routes/cadastro-promocao/cadastro-promocao.component';
import { RelatoriosComponent } from './routes/relatorios/relatorios.component';
import { RelatorioUsuarioComponent } from './routes/relatorios/relatorio-usuario/relatorio-usuario.component';
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LoginComponent,
    HomeUsuarioComponent,
    CadastroComponent,
    RedefinirSenhaComponent,
    CarteiraComponent,
    CarbonoComponent,
    BlogComponent,
    CadastroPromocaoComponent,
    RelatoriosComponent,
    RelatorioUsuarioComponent,
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyABybJZfNXwjLW10vkxSAdpmEEZHmxsaJ8'
    }), 
    RouterModule.forRoot([
      { path: '', component: LoginComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'home-usuario', component: HomeUsuarioComponent },
      { path: 'cadastro', component: CadastroComponent },
      { path: 'redefinirSenha', component: RedefinirSenhaComponent },
      { path: 'carteira', component: CarteiraComponent },
      { path: 'carbono', component: CarbonoComponent },
      { path: 'homeUsuario', component: HomeUsuarioComponent },
      { path: 'blog', component: BlogComponent },
      { path: 'casatroPromocao', component: CadastroPromocaoComponent },
      { path: 'relatorios', component: RelatoriosComponent } 
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
