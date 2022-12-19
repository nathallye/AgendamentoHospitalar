import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { BeneficiarioListaComponent } from './beneficiario-lista';
import { BeneficiarioDetalheComponent } from './beneficiario-detalhe/beneficiario-detalhe.component';
import { BeneficiarioCriarComponent } from './beneficiario-criar/beneficiario-criar.component';
import { BeneficiarioEditarComponent } from './beneficiario-editar/beneficiario-editar.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    BeneficiarioListaComponent,
    BeneficiarioDetalheComponent,
    BeneficiarioCriarComponent,
    BeneficiarioEditarComponent
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
