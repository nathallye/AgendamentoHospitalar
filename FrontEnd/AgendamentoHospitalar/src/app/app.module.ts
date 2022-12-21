import { AppComponent } from './app.component';
import { HeaderComponent } from "./templates/header/header.component";
import { FooterComponent } from './templates/footer/footer.component';

import { CriarAgendamentoconfigComponent } from './components/agendamentoconfig/criar-agendamentoconfig/criar-agendamentoconfig.component';
import { DetalheAgendamentoconfigComponent } from './components/agendamentoconfig/detalhe-agendamentoconfig/detalhe-agendamentoconfig.component';
import { ExcluirAgendamentoconfigComponent } from './components/agendamentoconfig/excluir-agendamentoconfig/excluir-agendamentoconfig.component';
import { ListarAgendamentoconfigComponent } from './components/agendamentoconfig/listar-agendamentoconfig/listar-agendamentoconfig.component';
import { EditarAgendamentoconfigComponent } from './components/agendamentoconfig/editar-agendamentoconfig/editar-agendamentoconfig.component';

import { CriarEspecialidadeComponent } from './components/especialidades/criar-especialidade/criar-especialidade.component';
import { ListarEspecialidadesComponent } from './components/especialidades/listar-especialidades/listar-especialidades.component';
import { EditarEspecialidadeComponent } from './components/especialidades/editar-especialidade/editar-especialidade.component';
import { DetalheEspecialidadeComponent } from './components/especialidades/detalhe-especialidade/detalhe-especialidade.component';
import { ExcluirEspecialidadeComponent } from './components/especialidades/excluir-especialidade/excluir-especialidade.component';

import { BeneficiarioListaComponent } from './beneficiario-lista';
import { BeneficiarioDetalheComponent } from './beneficiario-detalhe/beneficiario-detalhe.component';
import { BeneficiarioCriarComponent } from './beneficiario-criar/beneficiario-criar.component';
import { BeneficiarioEditarComponent } from './beneficiario-editar/beneficiario-editar.component';
import { BeneficiarioExcluirComponent } from './beneficiario-excluir/beneficiario-excluir.component';

import { ProfissionalListaComponent } from './profissional-lista/profissional-lista.component';
import { ProfissionalExcluirComponent } from './profissional-excluir/profissional-excluir.component';
import { ProfissionalEditarComponent } from './profissional-editar/profissional-editar.component';
import { ProfissionalDetalheComponent } from './profissional-detalhe/profissional-detalhe.component';
import { ProfissionalCriarComponent } from './profissional-criar/profissional-criar.component';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
    declarations: [
        AppComponent,
        HeaderComponent,
        FooterComponent,
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
        ProfissionalCriarComponent
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        HttpClientModule,
        FormsModule,
        BrowserAnimationsModule,
        HttpClientModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})

export class AppModule { }
