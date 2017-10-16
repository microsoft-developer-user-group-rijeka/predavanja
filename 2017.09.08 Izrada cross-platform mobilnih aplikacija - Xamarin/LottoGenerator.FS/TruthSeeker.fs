namespace LottoGenerator.FS

type TruthSeeker() = 
    member this.GetWindowsTruth() : bool = true;
    member this.GetIOsTruth() : bool = true;
    member this.GetAndroidTruth() : bool = false;
