import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ProfissionalListaComponent } from './profissional-lista';
import { ProfissionalDetalheComponent } from './profissional-detalhe';
import { ProfissionalCriarComponent } from './profissional-criar';
import { ProfissionalEditarComponent } from './profissional-editar';
import { ProfissionalExcluirComponent } from './profissional-excluir';

const routes: Routes = [
  { path: 'profissional', component: ProfissionalListaComponent },
  { path: 'profissional/listarporid/:id', component: ProfissionalDetalheComponent },
  { path: 'profissional/criar', component: ProfissionalCriarComponent },
  { path: 'profissional/editar/:id', component: ProfissionalEditarComponent },
  { path: 'profissional/exluir/:id', component: ProfissionalExcluirComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
