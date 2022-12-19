import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { BeneficiarioListaComponent } from './beneficiario-lista';
import { BeneficiarioDetalheComponent } from './beneficiario-detalhe';

const routes: Routes = [
  { path: 'beneficiarios/listartodos', component: BeneficiarioListaComponent },
  { path: 'beneficiarios/listarporid/:id', component: BeneficiarioDetalheComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
