import { HttpClient } from '@angular/common/http';
import IEspecialidadeDTO  from 'src/app/interfaces/IEspecialidadeDTO';
import { Router } from '@angular/router';
import { Component } from '@angular/core';
import { map } from 'rxjs';

@Component({
  selector: 'app-listar-especialidades',
  templateUrl: './listar-especialidades.component.html',
  styleUrls: ['./listar-especialidades.component.css']
})

export class ListarEspecialidadesComponent {
  EspecialidadesLista:IEspecialidadeDTO[] = [];
  telaApresentar:string = 'listar';

  constructor(private http:HttpClient, private router: Router){
    this.listarEspecialidades()
  }

  listarEspecialidades(){
    this.http.get('https://localhost:7275/ListarEspecialidades', )
    .pipe(
      map(response=> Object.values(response))
    )
    .subscribe(data=>{
      for(let i =0; i<data.length;i++){
        let novaEspecialidade:IEspecialidadeDTO = data[i]
        this.EspecialidadesLista.push(novaEspecialidade)
      }
    })
  }

  listarPorId(id: number) {
    this.router.navigate([`especialidade/detalhe/:${id}`]);
  }

  criar() {
    this.router.navigate(['especialidade/cadastrar']);
  }

  editar(id: number) {
    this.router.navigate([`especialidade/editar/${id}`]);
  }

  excluir(id: number) {
    this.router.navigate([`especialidade/excluir/${id}`]);
  }
}
