import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { Ng2SearchPipeModule } from 'ng2-search-filter';

import { AppComponent } from './app.component';
import { HeaderComponent } from "./components/header";

import { CriarAgendamentoconfigComponent } from './components/agendamentoconfig/criar-agendamentoconfig';
import { DetalheAgendamentoconfigComponent } from './components/agendamentoconfig/detalhe-agendamentoconfig';
import { ExcluirAgendamentoconfigComponent } from './components/agendamentoconfig/excluir-agendamentoconfig';
import { ListarAgendamentoconfigComponent } from './components/agendamentoconfig/listar-agendamentoconfig';
import { EditarAgendamentoconfigComponent } from './components/agendamentoconfig/editar-agendamentoconfig';

import { CriarEspecialidadeComponent } from './components/especialidades/criar-especialidade';
import { ListarEspecialidadesComponent } from './components/especialidades/listar-especialidades';
import { EditarEspecialidadeComponent } from './components/especialidades/editar-especialidade';
import { DetalheEspecialidadeComponent } from './components/especialidades/detalhe-especialidade';
import { ExcluirEspecialidadeComponent } from './components/especialidades/excluir-especialidade';

import { BeneficiarioListaComponent } from './components/beneficiario/beneficiario-lista';
import { BeneficiarioDetalheComponent } from './components/beneficiario/beneficiario-detalhe';
import { BeneficiarioCriarComponent } from './components/beneficiario/beneficiario-criar';
import { BeneficiarioEditarComponent } from './components/beneficiario/beneficiario-editar';
import { BeneficiarioExcluirComponent } from './components/beneficiario/beneficiario-excluir';

import { ProfissionalListaComponent } from './components/profissional/profissional-lista';
import { ProfissionalExcluirComponent } from './components/profissional/profissional-excluir';
import { ProfissionalEditarComponent } from './components/profissional/profissional-editar';
import { ProfissionalDetalheComponent } from './components/profissional/profissional-detalhe';
import { ProfissionalCriarComponent } from './components/profissional/profissional-criar';

import { HospitalListaComponent } from './components/hospital/hospital-lista';
import { HospitalExcluirComponent } from './components/hospital/hospital-excluir';
import { HospitalEditarComponent } from './components/hospital/hospital-editar';
import { HospitalDetalheComponent } from './components/hospital/hospital-detalhe';
import { HospitalCriarComponent } from './components/hospital/hospital-criar';

import { AgendamentoListaComponent } from './components/agendamento/agendamento-lista';
import { AgendamentoDetalheComponent } from './components/agendamento/agendamento-detalhe';
import { AgendamentoCriarComponent } from './components/agendamento/agendamento-criar';

import { HomeComponent } from './components/home';

//import { SearchPipe } from './search.pipe';

@NgModule({
    declarations: [
        AppComponent,
        HeaderComponent,
        CriarAgendamentoconfigComponent,
        DetalheAgendamentoconfigComponent,
        ExcluirAgendamentoconfigComponent,
        ListarAgendamentoconfigComponent,
        EditarAgendamentoconfigComponent,
        ListarEspecialidadesComponent,
        CriarEspecialidadeComponent,
        EditarEspecialidadeComponent,
        DetalheEspecialidadeComponent,
        ExcluirEspecialidadeComponent,
        BeneficiarioListaComponent,
        BeneficiarioDetalheComponent,
        BeneficiarioCriarComponent,
        BeneficiarioEditarComponent,
        BeneficiarioExcluirComponent,
        ProfissionalListaComponent,
        ProfissionalExcluirComponent,
        ProfissionalEditarComponent,
        ProfissionalDetalheComponent,
        ProfissionalCriarComponent,
        HospitalListaComponent,
        HospitalExcluirComponent,
        HospitalEditarComponent,
        HospitalDetalheComponent,
        HospitalCriarComponent,
        AgendamentoListaComponent,
        AgendamentoDetalheComponent,
        AgendamentoCriarComponent,
        //SearchPipe
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        HttpClientModule,
        FormsModule,
        BrowserAnimationsModule,
        Ng2SearchPipeModule,
        CommonModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})

export class AppModule { }
