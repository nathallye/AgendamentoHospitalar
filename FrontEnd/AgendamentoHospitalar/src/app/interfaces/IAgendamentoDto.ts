import { IBeneficiarioDto } from "./IBeneficiarioDto";
import IEspecialidadeDTO from "./IEspecialidadeDTO";
import { IHospitalDto } from "./IHospitalDto";
import { IProfissionalDto } from "./IProfissionalDto";

export interface IAgendamentoDto {
  idAgendamento: number,
  idBeneficiario: number,
  idHospital: number,
  idEspecialidade: number,
  idProfissional: number,
  dataHoraAgendamento: Date,
  ativo: boolean
}
