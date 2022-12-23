import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { map } from 'rxjs';

import { IProfissionalDto } from '../../../interfaces/IProfissionalDto';

@Component({
  selector: 'app-profissional-lista',
  templateUrl: '../profissional-lista/profissional-lista.component.html',
  styleUrls: ['../profissional-lista/profissional-lista.component.css']
})
export class ProfissionalListaComponent {
  listaProfissional: IProfissionalDto[] = [];

  constructor(private http: HttpClient, private router: Router) {
    this.listarTodos();
  }

  listarTodos() {
    this.listaProfissional = [];

    this.http
      .get('https://localhost:7275/api/Profissional/ListarTodos')
      .pipe(
        map((response: any) => {
          return Object.values(response);
        })
      )
      .subscribe((data) => {
        for (let i = 0; i < data.length; i++) {
          let contentJson: any = data[i];
          this.listaProfissional.push(contentJson as IProfissionalDto);
        }
      });
  }


  listarPorId(id: number) {
    console.log('Aquiiiiiii');
    this.router.navigate([`profissional/listarporid/${id}`]);
  }

  criar() {
    this.router.navigate(['profissional/criar']);
  }

  editar(id: number) {
    this.router.navigate([`profissional/editar/${id}`]);
  }

  excluir(id: number) {
    this.router.navigate([`profissional/exluir/${id}`]);
  }
}
