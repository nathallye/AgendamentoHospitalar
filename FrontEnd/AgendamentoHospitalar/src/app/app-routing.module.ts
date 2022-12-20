import { ExcluirEspecialidadeComponent } from './components/especialidades/excluir-especialidade/excluir-especialidade.component';
import { DetalheEspecialidadeComponent } from './components/especialidades/detalhe-especialidade/detalhe-especialidade.component';
import { EditarEspecialidadeComponent } from './components/especialidades/editar-especialidade/editar-especialidade.component';
import { CriarEspecialidadeComponent } from './components/especialidades/criar-especialidade/criar-especialidade.component';
import { ListarEspecialidadesComponent } from './components/especialidades/listar-especialidades/listar-especialidades.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path:'especialidade/cadastrar', component:CriarEspecialidadeComponent},
  {path:'especialidade/detalhe/:id', component:DetalheEspecialidadeComponent},
  {path:'especialidade/editar/:id', component:EditarEspecialidadeComponent},
  {path:'especialidade/excluir/:id', component:ExcluirEspecialidadeComponent},
  {path:'', component:ListarEspecialidadesComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
