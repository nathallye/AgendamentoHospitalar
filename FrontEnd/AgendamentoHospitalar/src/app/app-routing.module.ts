import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ProfissionalListaComponent } from './profissional-lista';
import { ProfissionalDetalheComponent } from './profissional-detalhe';
import { ProfissionalCriarComponent } from './profissional-criar';
import { ProfissionalEditarComponent } from './profissional-editar';
import { ProfissionalExcluirComponent } from './profissional-excluir/profissional-excluir.component';

const routes: Routes = [
  { path: 'profissionais/listartodos', component: ProfissionalListaComponent },
  { path: 'profissionais/listarporid/:id', component: ProfissionalDetalheComponent },
  { path: 'profissionais/criar', component: ProfissionalCriarComponent },
  { path: 'profissionais/editar/:id', component: ProfissionalEditarComponent },
  { path: 'profissionais/exluir/:id', component: ProfissionalExcluirComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
