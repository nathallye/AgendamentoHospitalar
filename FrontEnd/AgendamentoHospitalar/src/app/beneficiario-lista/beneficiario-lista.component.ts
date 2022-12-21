import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { map } from 'rxjs';

import { IBeneficiarioDto } from '../interfaces/IBeneficiarioDto';

@Component({
  selector: 'app-beneficiario-lista',
  templateUrl: './beneficiario-lista.component.html',
  styleUrls: ['./beneficiario-lista.component.css']
})
export class BeneficiarioListaComponent {
  listaBeneficiarios: IBeneficiarioDto[] = [];

  constructor(private http: HttpClient, private router: Router) {
    this.listarTodos();
  }

  listarTodos() {
    this.listaBeneficiarios = [];

    this.http
      .get('https://localhost:7275/api/Beneficiarios/ListarTodos')
      .pipe(
        map((response: any) => {
          return Object.values(response);
        })
      )
      .subscribe((data) => {
        for (let i = 0; i < data.length; i++) {
          let contentJson: any = data[i];
          this.listaBeneficiarios.push(contentJson as IBeneficiarioDto);
        }
      });
  }


  listarPorId(id: number) {
    this.router.navigate([`beneficiarios/listarporid/${id}`]);
  }

  criar() {
    this.router.navigate(['beneficiarios/criar']);
  }
  
  editar(id: number) {
    this.router.navigate([`beneficiarios/editar/${id}`]);
  }

  excluir(id: number) {
    this.router.navigate([`beneficiarios/exluir/${id}`]);
  }
}
