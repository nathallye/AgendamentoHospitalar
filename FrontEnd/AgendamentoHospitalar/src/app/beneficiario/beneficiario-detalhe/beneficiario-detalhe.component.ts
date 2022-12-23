import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { IBeneficiarioDto } from '../../interfaces/IBeneficiarioDto';

@Component({
  selector: 'app-beneficiario-detalhe',
  templateUrl: './beneficiario-detalhe.component.html',
  styleUrls: ['./beneficiario-detalhe.component.css']
})
export class BeneficiarioDetalheComponent {
  beneficiario!: IBeneficiarioDto;
  idRecebido!: number;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.route.paramMap.subscribe(params => {
      this.idRecebido = Number(params.get('id'));
    });
  }

  ngOnInit(): void {
    if (this.idRecebido) {
      this.http
        .get(`https://localhost:7275/api/Beneficiarios/ListarPorId/${this.idRecebido}`)
        .subscribe((data) => {

          this.beneficiario = data as IBeneficiarioDto;

          this.beneficiario = {
            senha: this.beneficiario.senha,
            idBeneficiario: this.idRecebido,
            nome: this.beneficiario.nome,
            cpf: this.beneficiario.cpf,
            numeroCarteirinha: this.beneficiario.numeroCarteirinha,
            telefone: this.beneficiario.telefone,
            email: this.beneficiario.email,
            endereco: this.beneficiario.endereco,
            ativo: this.beneficiario.ativo
          }
        });
    }
  }

  fechar() {
    this.router.navigate(['beneficiarios/listartodos']);
  }
}
