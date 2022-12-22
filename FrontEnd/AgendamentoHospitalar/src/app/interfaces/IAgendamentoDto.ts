import { IBeneficiarioDto } from "./IBeneficiarioDto";
import IEspecialidadeDTO from "./IEspecialidadeDTO";
import { IHospitalDto } from "./IHospitalDto";
import { IProfissionalDto } from "./IProfissionalDto";

export interface IAgendamentoDto {
  nome: string;
  idAgendamento: number,
  idBeneficiario: number,
  idHospital: number,
  idEspecialidade: number,
  idProfissional: number,
  dataHoraAgendamento: Date,
  ativo: boolean,
  idBeneficiarioNavigation: IBeneficiarioDto,
  idHospitalNavigation: IHospitalDto,
  idEspecialidadeNavigation: IEspecialidadeDTO,
  idProfissionalNavigation: IProfissionalDto
}
