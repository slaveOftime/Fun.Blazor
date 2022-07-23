namespace Fun.Htmx

open System.Text
open Fun.Result


[<RequireQualifiedAccess>]
type HxQueue =
    | First
    | Last
    | All
    | None

    override this.ToString() = this.ToString().ToLower()


type TriggerBuilder() =
    let sb = new StringBuilder()

    member this.AddTrigger
        (
            event: string,
            ?sse: bool,
            ?filter: string,
            ?once: bool,
            ?changed: bool,
            ?delay: int,
            ?throttle: int,
            ?from: string,
            ?target: string,
            ?consume: bool,
            ?queue: HxQueue
        )
        =
        if sb.Length > 0 then sb.Append(", ") |> ignore

        match sse with
        | Some true -> sb.Append("sse:") |> ignore
        | _ -> ()

        sb.Append(event) |> ignore

        match filter with
        | Some (SafeString f) -> sb.Append("[").Append(f).Append("]") |> ignore
        | _ -> ()

        match once with
        | Some true -> sb.Append(" once") |> ignore
        | _ -> ()

        match changed with
        | Some true -> sb.Append(" changed") |> ignore
        | _ -> ()

        match delay with
        | Some d when d > 0 -> sb.Append(" delay:").Append(d).Append("ms") |> ignore
        | _ -> ()

        match throttle with
        | Some t when t > 0 -> sb.Append(" throttle:").Append(t).Append("ms") |> ignore
        | _ -> ()

        match from with
        | Some f -> sb.Append(" from:").Append(f) |> ignore
        | _ -> ()

        match target with
        | Some t -> sb.Append(" target:").Append(t) |> ignore
        | _ -> ()

        match consume with
        | Some true -> sb.Append(" consume") |> ignore
        | _ -> ()

        match queue with
        | Some HxQueue.None -> ()
        | Some q -> sb.Append(" queue:").Append(q.ToString()) |> ignore
        | _ -> ()

        this


    override _.ToString() = sb.ToString()
