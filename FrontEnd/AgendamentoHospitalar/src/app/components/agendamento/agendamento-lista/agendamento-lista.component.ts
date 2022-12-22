import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { map } from 'rxjs';

import { IAgendamentoDto } from '../../../interfaces/IAgendamentoDto';

@Component({
  selector: 'app-agendamento-lista',
  templateUrl: './agendamento-lista.component.html',
  styleUrls: ['./agendamento-lista.component.css']
})
export class AgendamentoListaComponent {
  listaAgendamentos: IAgendamentoDto[] = [];

  constructor(private http: HttpClient, private router: Router) {
    this.listarTodos();
  }

  listarTodos() {
    this.listaAgendamentos = [];

    this.http
      .get('https://localhost:7275/api/Agendamentos/ListarTodos')
      .pipe(
        map((response: any) => {
          return Object.values(response);
        })
      )
      .subscribe((data) => {
        for (let i = 0; i < data.length; i++) {
          let contentJson: any = data[i];
          this.listaAgendamentos.push(contentJson as IAgendamentoDto);
        }
      });
  }

  listarPorId(id: number) {
    this.router.navigate([`agendamentos/listarporid/${id}`]);
  }

  criar() {
    this.router.navigate(['agendamentos/criar']);
  }

  editar(id: number) {
    this.router.navigate([`agendamentos/editar/${id}`]);
  }

  excluir(id: number) {
    this.router.navigate([`agendamentos/exluir/${id}`]);
  }
}


