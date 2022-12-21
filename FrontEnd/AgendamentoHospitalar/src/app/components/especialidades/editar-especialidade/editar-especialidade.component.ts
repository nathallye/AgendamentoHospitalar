import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import IEspecialidadeDTO from 'src/app/interfaces/IEspecialidadeDTO';

@Component({
  selector: 'app-editar-especialidade',
  templateUrl: './editar-especialidade.component.html',
  styleUrls: ['./editar-especialidade.component.css']
})
export class EditarEspecialidadeComponent {
  novaEspecialidade! :IEspecialidadeDTO;

  constructor(private http:HttpClient, private router:Router){}

  cadastrar(){
    this.http.post('https://localhost:7275/CadastrarEspecialidade',{
    ativo:this.novaEspecialidade.ativo,
    descrição:this.novaEspecialidade.descricao,
    nome: this.novaEspecialidade.nome,
    idEspecialidade: 0
    })
    .subscribe(data=>{
      this.router.navigate([``])
    })
  }

}
