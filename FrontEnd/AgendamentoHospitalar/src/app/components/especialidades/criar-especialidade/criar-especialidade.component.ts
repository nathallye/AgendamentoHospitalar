import { Router } from '@angular/router';
import { Component, Input } from '@angular/core';
import IEspecialidadeDTO from 'src/app/interfaces/IEspecialidadeDTO';
import {HttpClient} from '@angular/common/http'
@Component({
  selector: 'app-criar-especialidade',
  templateUrl: './criar-especialidade.component.html',
  styleUrls: ['./criar-especialidade.component.css']
})
export class CriarEspecialidadeComponent {

  novaEspecialidade :IEspecialidadeDTO = {
    ativo:true,
    descricao:'',
    nome: '',
    idEspecialidade: 0
  };

  constructor(private http:HttpClient, private router:Router){}

  cadastrar(){
    this.http.post('https://localhost:7275/CadastrarEspecialidade',{
    ativo:this.novaEspecialidade.ativo,
    descrição:this.novaEspecialidade.descricao,
    nome: this.novaEspecialidade.nome,
    idEspecialidade: 0
    })
    .subscribe(data=>{
      this.router.navigate([`especialidade/detalhe`])
    })
  }

}
