import { PackageItemRelation } from "./packageItemModel";

export class Package {
  title?: string;
  description?: string;
  totalSalary: number;
  packageItemRelations?: PackageItemRelation[];
  id: number;
}
