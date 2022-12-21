import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HospitalListaComponent } from './hospital-lista/hospital-lista.component';
import { HospitalExcluirComponent } from './hospital-excluir/hospital-excluir.component';
import { HospitalEditarComponent } from './hospital-editar/hospital-editar.component';
import { HospitalDetalheComponent } from './hospital-detalhe/hospital-detalhe.component';
import { HospitalCriarComponent } from './hospital-criar/hospital-criar.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HospitalListaComponent,
    HospitalExcluirComponent,
    HospitalEditarComponent,
    HospitalDetalheComponent,
    HospitalCriarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    BrowserAnimationsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
