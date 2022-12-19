import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { BeneficiarioListaComponent } from './beneficiario-lista';
import { BeneficiarioDetalheComponent } from './beneficiario-detalhe';
import { BeneficiarioCriarComponent } from './beneficiario-criar';
import { BeneficiarioEditarComponent } from './beneficiario-editar/beneficiario-editar.component';

const routes: Routes = [
  { path: 'beneficiarios/listartodos', component: BeneficiarioListaComponent },
  { path: 'beneficiarios/listarporid/:id', component: BeneficiarioDetalheComponent },
  { path: 'beneficiarios/criar', component: BeneficiarioCriarComponent },
  { path: 'beneficiarios/editar/:id', component: BeneficiarioEditarComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
