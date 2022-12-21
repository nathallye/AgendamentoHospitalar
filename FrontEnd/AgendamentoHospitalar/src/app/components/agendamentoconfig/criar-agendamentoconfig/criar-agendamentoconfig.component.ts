import { ListarEspecialidadesComponent } from './../../especialidades/listar-especialidades/listar-especialidades.component';
import IEspecialidadeDTO  from 'src/app/interfaces/IEspecialidadeDTO';
import IAgendamentoConfiguracaoDTO  from 'src/app/interfaces/IAgendamentoConfiguracaoDTO';
import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { map } from 'rxjs';

@Component({
  selector: 'app-criar-agendamentoconfig',
  templateUrl: './criar-agendamentoconfig.component.html',
  styleUrls: ['./criar-agendamentoconfig.component.css']
})
export class CriarAgendamentoconfigComponent {
  listaEspecialidades:IEspecialidadeDTO[] = [];
  novoAgendamentoConfig :IAgendamentoConfiguracaoDTO = {
  dataHoraFinalAtendimento : new Date(),
  dataHoraInicioAtendimento: new Date(),
  idConfiguracao: 0,
  idEspecialidade: 0,
  idHospital: 0,
  idProfissional: 0
 };

  constructor(private http:HttpClient, private router:Router){
    this.listarEspecialidades()
  }

  listarEspecialidades(){
    this.http.get('https://localhost:7275/ListarEspecialidades', )
    .pipe(
      map(response=> Object.values(response))
    )
    .subscribe(data=>{
      for(let i =0; i<data.length;i++){
        let novaEspecialidade:IEspecialidadeDTO = {
          ativo: data[i].ativo,
          descricao: data[i].descrição,
          nome: data[i].nome,
          idEspecialidade: data[i].idEspecialidade
        }
        this.listaEspecialidades.push(novaEspecialidade)
      }
    })
  }

  cadastrar(){
    this.http.post('https://localhost:7275/CadastrarAgendamentoConfig', this.novoAgendamentoConfig)
    .subscribe(data=>{
      this.router.navigate([`agendamentoconfig`])
    })
  }
}
