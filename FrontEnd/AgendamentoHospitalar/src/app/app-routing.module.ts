import { HomeComponent } from './home/home.component';
import { ListarAgendamentoconfigComponent } from './components/agendamentoconfig/listar-agendamentoconfig/listar-agendamentoconfig.component';
import { ExcluirAgendamentoconfigComponent } from './components/agendamentoconfig/excluir-agendamentoconfig/excluir-agendamentoconfig.component';
import { EditarAgendamentoconfigComponent } from './components/agendamentoconfig/editar-agendamentoconfig/editar-agendamentoconfig.component';
import { DetalheAgendamentoconfigComponent } from './components/agendamentoconfig/detalhe-agendamentoconfig/detalhe-agendamentoconfig.component';
import { CriarAgendamentoconfigComponent } from './components/agendamentoconfig/criar-agendamentoconfig/criar-agendamentoconfig.component';

import { ExcluirEspecialidadeComponent } from './components/especialidades/excluir-especialidade/excluir-especialidade.component';
import { DetalheEspecialidadeComponent } from './components/especialidades/detalhe-especialidade/detalhe-especialidade.component';
import { EditarEspecialidadeComponent } from './components/especialidades/editar-especialidade/editar-especialidade.component';
import { CriarEspecialidadeComponent } from './components/especialidades/criar-especialidade/criar-especialidade.component';
import { ListarEspecialidadesComponent } from './components/especialidades/listar-especialidades/listar-especialidades.component';

import { BeneficiarioListaComponent } from './beneficiario-lista';
import { BeneficiarioDetalheComponent } from './beneficiario-detalhe';
import { BeneficiarioCriarComponent } from './beneficiario-criar';
import { BeneficiarioEditarComponent } from './beneficiario-editar/beneficiario-editar.component';
import { BeneficiarioExcluirComponent } from './beneficiario-excluir/beneficiario-excluir.component';

import { ProfissionalListaComponent } from './profissional-lista';
import { ProfissionalDetalheComponent } from './profissional-detalhe';
import { ProfissionalCriarComponent } from './profissional-criar';
import { ProfissionalEditarComponent } from './profissional-editar';
import { ProfissionalExcluirComponent } from './profissional-excluir';

import { HospitalListaComponent } from './hospital-lista';
import { HospitalDetalheComponent } from './hospital-detalhe';
import { HospitalCriarComponent } from './hospital-criar';
import { HospitalEditarComponent } from './hospital-editar';
import { HospitalExcluirComponent } from './hospital-excluir/hospital-excluir.component';

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AgendamentoListaComponent } from './components/agendamento/agendamento-lista/agendamento-lista.component';

const routes: Routes = [
  {path:'agendamentoconfig', component:ListarAgendamentoconfigComponent},
  {path:'agendamentoconfig/cadastrar', component:CriarAgendamentoconfigComponent},
  {path:'agendamentoconfig/detalhe/:id', component:DetalheAgendamentoconfigComponent},
  {path:'agendamentoconfig/editar/:id', component:EditarAgendamentoconfigComponent},
  {path:'agendamentoconfig/excluir/:id', component:ExcluirAgendamentoconfigComponent},

  {path:'especialidade', component:ListarEspecialidadesComponent},
  {path:'especialidade/cadastrar', component:CriarEspecialidadeComponent},
  {path:'especialidade/detalhe/:id', component:DetalheEspecialidadeComponent},
  {path:'especialidade/editar/:id', component:EditarEspecialidadeComponent},
  {path:'especialidade/excluir/:id', component:ExcluirEspecialidadeComponent},

  { path: 'beneficiarios/listartodos', component: BeneficiarioListaComponent },
  { path: 'beneficiarios/listarporid/:id', component: BeneficiarioDetalheComponent },
  { path: 'beneficiarios/criar', component: BeneficiarioCriarComponent },
  { path: 'beneficiarios/editar/:id', component: BeneficiarioEditarComponent },
  { path: 'beneficiarios/exluir/:id', component: BeneficiarioExcluirComponent },

  { path: 'profissional', component: ProfissionalListaComponent },
  { path: 'profissional/listarporid/:id', component: ProfissionalDetalheComponent },
  { path: 'profissional/criar', component: ProfissionalCriarComponent },
  { path: 'profissional/editar/:id', component: ProfissionalEditarComponent },
  { path: 'profissional/exluir/:id', component: ProfissionalExcluirComponent },

  { path: 'hospital/listartodos', component: HospitalListaComponent },
  { path: 'hospital/listarporid/:id', component: HospitalDetalheComponent },
  { path: 'hospital/criar', component: HospitalCriarComponent },
  { path: 'hospital/editar/:id', component: HospitalEditarComponent },
  { path: 'hospital/exluir/:id', component: HospitalExcluirComponent },

  { path: 'agendamentos/listartodos', component: AgendamentoListaComponent },

  {path: 'home', component: HomeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
