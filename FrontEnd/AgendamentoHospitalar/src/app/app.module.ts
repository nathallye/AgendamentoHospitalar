import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { ProfissionalListaComponent } from './profissional-lista/profissional-lista.component';
import { ProfissionalExcluirComponent } from './profissional-excluir/profissional-excluir.component';
import { ProfissionalEditarComponent } from './profissional-editar/profissional-editar.component';
import { ProfissionalDetalheComponent } from './profissional-detalhe/profissional-detalhe.component';
import { ProfissionalCriarComponent } from './profissional-criar/profissional-criar.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ProfissionalListaComponent,
    ProfissionalExcluirComponent,
    ProfissionalEditarComponent,
    ProfissionalDetalheComponent,
    ProfissionalCriarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    BrowserAnimationsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
