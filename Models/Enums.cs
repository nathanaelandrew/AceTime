namespace BlazorApp1.Models;

public enum UserRole { Player, Organizer, Admin, SuperAdmin }
public enum EventType { OpenPlay, Tournament, League, Clinic }
public enum RSVPStatus { Going, Waitlisted, Cancelled, NoShow }
public enum TransactionStatus { Pending, Completed, Failed, Refunded }
public enum MembershipRole { Owner, Admin, Member, Guest }
public enum MatchStatus { Scheduled, Live, Completed, Forfeit }