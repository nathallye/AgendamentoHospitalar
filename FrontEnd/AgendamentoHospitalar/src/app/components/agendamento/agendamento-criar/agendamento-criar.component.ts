import { IProfissionalDto } from './../../../interfaces/IProfissionalDto';
import  IEspecialidadeDTO  from 'src/app/interfaces/IEspecialidadeDTO';
import { IHospitalDto } from './../../../interfaces/IHospitalDto';
import { IBeneficiarioDto } from './../../../interfaces/IBeneficiarioDto';
import  IAgendamentoConfiguracaoDTO  from 'src/app/interfaces/IAgendamentoConfiguracaoDTO';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IAgendamentoDto } from 'src/app/interfaces/IAgendamentoDto';
import { map } from 'rxjs';
import IAgendamentoConfiguracao from 'src/app/interfaces/IAgendamentoConfiguracao';

@Component({
  selector: 'app-agendamento-criar',
  templateUrl: './agendamento-criar.component.html',
  styleUrls: ['./agendamento-criar.component.css']
})
export class AgendamentoCriarComponent {
    novoAgendamento:IAgendamentoDto = {
      ativo: true,
      dataHoraAgendamento: new Date(),
      idAgendamento: 0,
      idBeneficiario: 0,
      idEspecialidade: 0,
      idHospital: 0,
      idProfissional: 0,
    };
    listaAgendamentoConfig:IAgendamentoConfiguracao[] = [];
    listaEspecialidade:any[] =[];
    listaProfissional:IProfissionalDto[]=[]
    listaBeneficiario:IBeneficiarioDto[] = [];
    listaHospitais:IHospitalDto[]=[];
    selecao:number = 1;


  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.http.get('https://localhost:7275/ListarAgendamentoConfiguracao')
    .pipe(
      map(response=> Object.values(response))
    )
    .subscribe(data=>{
      for(let i =0; i<data.length;i++){
        let novoAgendamentoConfig:IAgendamentoConfiguracao= data[i];
        this.listaAgendamentoConfig.push(novoAgendamentoConfig)
      }
    })

    this.http.get('https://localhost:7275/api/Beneficiarios/ListarTodos',)
    .pipe(
      map(response=> Object.values(response))
    )
    .subscribe(data=>{
      for(let i =0; i<data.length;i++){
        let novoBeneficiario:IBeneficiarioDto = data[i];
        this.listaBeneficiario.push(novoBeneficiario)
      }
    })

    this.http.get('https://localhost:7275/api/Hospitais/ListarTodos',)
    .pipe(
      map(response=> Object.values(response))
    )
    .subscribe(data=>{
      for(let i =0; i<data.length;i++){
        let novoHospital:IHospitalDto= data[i];
        this.listaHospitais.push(novoHospital)
      }
    })

    this.http.get('https://localhost:7275/ListarEspecialidades',)
    .pipe(
      map(response=> Object.values(response))
    )
    .subscribe(data=>{
      for(let i =0; i<data.length;i++){
        let novaEspecialidade:any= {
          idEspecialidade: data[i].idEspecialidade,
          nome: data[i].nome,
          descricao: data[i].descricao,
          ativo: data[i].ativo
        };
        this.listaEspecialidade.push(novaEspecialidade)
      }
    })

    this.http.get('https://localhost:7275/api/Profissional/ListarTodos',)
    .pipe(
      map(response=> Object.values(response))
    )
    .subscribe(data=>{
      for(let i =0; i<data.length;i++){
        let novoProfissional:IProfissionalDto= data[i];
        this.listaProfissional.push(novoProfissional)
      }
    })
  }

  alterarEspecialidades(){
    this.listaEspecialidade = this.listaAgendamentoConfig.map(x =>x.idHospital == this.novoAgendamento.idHospital)
    console.log(`alterei`)
  }
}
