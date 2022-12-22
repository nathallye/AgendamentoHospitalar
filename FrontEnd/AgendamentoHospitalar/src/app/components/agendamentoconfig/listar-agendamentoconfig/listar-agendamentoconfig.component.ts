import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { map } from 'rxjs';
import IAgendamentoConfiguracaoDTO from 'src/app/interfaces/IAgendamentoConfiguracao';

@Component({
  selector: 'app-listar-agendamentoconfig',
  templateUrl: './listar-agendamentoconfig.component.html',
  styleUrls: ['./listar-agendamentoconfig.component.css']
})
export class ListarAgendamentoconfigComponent {
  agendamentoConfigLista:IAgendamentoConfiguracaoDTO[] = [];


  constructor(private http:HttpClient, private router: Router){
    this.listarAgendamentoConfig()
  }

  listarAgendamentoConfig(){
    this.http.get('https://localhost:7275/ListarAgendamentoConfiguracao', )
    .pipe(
      map(response=> Object.values(response))
    )
    .subscribe((data:any)=>{
      for(let i =0; i<data.length;i++){
        this.agendamentoConfigLista.push(data[i] as IAgendamentoConfiguracaoDTO)
      }
    })
  }

  listarPorId(id: number) {
    this.router.navigate([`agendamentoconfig/detalhe/:${id}`]);
  }

  criar() {
    this.router.navigate(['agendamentoconfig/cadastrar']);
  }

  editar(id: number) {
    this.router.navigate([`agendamentoconfig/editar/:${id}`]);
  }

  excluir(id: number) {
    this.router.navigate([`agendamentoconfig/excluir/${id}`]);
  }
}
