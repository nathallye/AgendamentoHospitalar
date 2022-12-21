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
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path:'especialidade', component:ListarEspecialidadesComponent},
  {path:'especialidade/cadastrar', component:CriarEspecialidadeComponent},
  {path:'especialidade/detalhe/:id', component:DetalheEspecialidadeComponent},
  {path:'especialidade/editar/:id', component:EditarEspecialidadeComponent},
  {path:'especialidade/excluir/:id', component:ExcluirEspecialidadeComponent},
  {path:'agendamentoconfig', component:ListarAgendamentoconfigComponent},
  {path:'agendamentoconfig/cadastrar', component:CriarAgendamentoconfigComponent},
  {path:'agendamentoconfig/detalhe/:id', component:DetalheAgendamentoconfigComponent},
  {path:'agendamentoconfig/editar/:id', component:EditarAgendamentoconfigComponent},
  {path:'agendamentoconfig/excluir/:id', component:ExcluirAgendamentoconfigComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
