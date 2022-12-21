import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { IHospitalDto } from '../interfaces/IHospitalDto';

@Component({
  selector: 'app-hospital-criar',
  templateUrl: './hospital-criar.component.html',
  styleUrls: ['./hospital-criar.component.css']
})
export class HospitalCriarComponent {
  hospital!: IHospitalDto;
  idRecebido!: number;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.route.paramMap.subscribe(params => {
      this.idRecebido = Number(params.get('id'));
    });
  }

  ngOnInit(): void {
    this.hospital = {
      idHospital: this.idRecebido ?? 0,
      nome: '',
      cnpj: '',
      endereco: '',
      telefone: '',
      cnes: '',
      ativo: true
    }
  }

  salvar() {
    if (this.validarInformacoes()) {
      if (this.hospital.idHospital == 0) {

        this.http.post('https://localhost:7275/api/Hospitais/Criar', this.hospital)
          .subscribe((data) => {
            this.router.navigate(['hospital/listartodos']);
          });
      } else {
        console.log('Erro na validação');
        // TRATAMENTO DE ERRO
        // ALERTA
        // BORDA VERMELHA
      }
    }
  }

  validarInformacoes(): boolean {
    if (this.hospital.nome == '') {
      return false;
    }

    // VALIDAR COM REGEX

    return true;
  }

  sair() {
    this.router.navigate(['hospital/listartodos']);
  }
}
