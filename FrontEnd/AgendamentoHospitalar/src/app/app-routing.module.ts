import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { BeneficiarioListaComponent } from './beneficiario-lista';

const routes: Routes = [
  { path: 'beneficiarios/listartodos', component: BeneficiarioListaComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
