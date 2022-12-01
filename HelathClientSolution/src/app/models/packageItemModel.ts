import { Package } from "./packageModel";

export class PackageItemRelation {
  packageType: number;
  title?: string;
  total: number;
  packageId: number;
  package?: Package;
  id: number;
}

