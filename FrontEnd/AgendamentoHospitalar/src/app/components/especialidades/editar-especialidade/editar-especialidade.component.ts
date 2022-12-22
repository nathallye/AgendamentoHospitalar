import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import IEspecialidadeDTO from 'src/app/interfaces/IEspecialidadeDTO';

@Component({
  selector: 'app-editar-especialidade',
  templateUrl: './editar-especialidade.component.html',
  styleUrls: ['./editar-especialidade.component.css']
})
export class EditarEspecialidadeComponent  implements OnInit{
  novaEspecialidade :IEspecialidadeDTO = {
  ativo: true,
  descricao: ``,
  idEspecialidade: 0,
  nome: ``
  };
  idRecebido!:number;

  constructor(private http:HttpClient,private route:ActivatedRoute, private router:Router){
    this.route.paramMap.subscribe(params => {
      this.idRecebido = Number(params.get('id'));
    });

  }
  ngOnInit(): void {
    this.carregarEspecialidade()
  }

  carregarEspecialidade(){
    this.http.get(`https://localhost:7275/ListarEspecialidades/${this.idRecebido}`,)
    .subscribe((data:any ) =>{
      console.log(data)
      this.novaEspecialidade = data as IEspecialidadeDTO})
  }
  atualizar(){
    this.http.post('https://localhost:7275/AtualizarEspecialidade', this.novaEspecialidade)
    .subscribe(data=>{
      this.router.navigate([`especialidade`])
    })
  }

}
