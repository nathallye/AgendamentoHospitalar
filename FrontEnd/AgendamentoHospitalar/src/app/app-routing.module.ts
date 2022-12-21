import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HospitalListaComponent } from './hospital-lista';
import { HospitalDetalheComponent } from './hospital-detalhe';
import { HospitalCriarComponent } from './hospital-criar';
import { HospitalEditarComponent } from './hospital-editar';
import { HospitalExcluirComponent } from './hospital-excluir/hospital-excluir.component';

const routes: Routes = [
  { path: 'hospital/listartodos', component: HospitalListaComponent },
  { path: 'hospital/listarporid/:id', component: HospitalDetalheComponent },
  { path: 'hospital/criar', component: HospitalCriarComponent },
  { path: 'hospital/editar/:id', component: HospitalEditarComponent },
  { path: 'hospital/exluir/:id', component: HospitalExcluirComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
