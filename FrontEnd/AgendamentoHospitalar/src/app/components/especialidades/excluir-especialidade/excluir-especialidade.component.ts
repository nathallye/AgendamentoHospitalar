import IEspecialidadeDTO  from 'src/app/interfaces/IEspecialidadeDTO';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { map } from 'rxjs';

@Component({
  selector: 'app-excluir-especialidade',
  templateUrl: './excluir-especialidade.component.html',
  styleUrls: ['./excluir-especialidade.component.css']
})
export class ExcluirEspecialidadeComponent {
  especialidade: IEspecialidadeDTO = {
    ativo: false,
    descricao: ``,
    nome:``,
    idEspecialidade: 0
  };
  idRecebido!: number;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.route.paramMap.subscribe(params => {
      this.idRecebido = Number(params.get('id'));
    });
  }

  ngOnInit(): void {
    console.log(this.idRecebido)
    if (this.idRecebido) {
      this.http
        .get(`https://localhost:7275/ListarEspecialidades/${this.idRecebido}`)
        .subscribe((data:any) => {
          this.especialidade = {
            ativo: data.ativo,
            descricao: data.descrição,
            nome: data.nome,
            idEspecialidade: data.idEspecialidade
          };
          console.log(this.especialidade)
        });

    }
  }

  apagar() {
    if (this.especialidade.idEspecialidade !== 0) {
      this.http.delete(`https://localhost:7275/DeletarEspecialidade/${this.idRecebido}`)
      .subscribe((data) => {
        this.router.navigate(['']);
      });

    } else {
      console.log('Erro na validação');
    }
  }

  sair() {
    this.router.navigate(['']);
  }
}
